using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaServerTray {

    public class RecStatus {
        public enum eRecording {  Started, Stopped, None, Recording, Error};
        public eRecording Status { get; set; } = eRecording.None;
        public int NextRecording { get; set; } = 0;
        public string ErrorMsg { get; set; } = string.Empty;
        public int WaitTime { get; set; } = 120;
    }
    public class StatusWorker {

    
        MS_Service msService;
       
        public int NextPollOnError { get; set; } = 120;
        public int NextPollOnRecording { get; set; } = 60;
        public int NextPollOnWaiting { get; set; } = 60;

        private bool actualRecording = false;

        public bool Stop { get; set; } = false;
        public bool IsRunning { get; set; } = false;



        public StatusWorker(MS_Service service) {
            msService = service;
        }

        private bool MySleep(int seconds) {
            int counter = 0;
            while (counter < seconds) {
                System.Threading.Thread.Sleep(2000);
                counter += 2;
                if (Stop)
                    return false;
            }
            return true;
        }

        async public void RunLoop(Action<RecStatus> OnEvent) {
            Stop = false;
            IsRunning = true;
            while (true) {
                RecStatus reStat = await GetStatusUpdate();
                OnEvent?.Invoke(reStat);
                if (MySleep(reStat.WaitTime * 1000) == false) {
                    IsRunning = false;
                    return;
                }
                //if (Stop) return;
                //System.Threading.Thread.Sleep(reStat.WaitTime * 1000);
            }
        }


        async public Task<string> DoRequest(MS_Status msStatus) {
            string errMsg = string.Empty;
            try {
                string url = msService.MS_Url(MS_Status.Endpoint);
                string xmlString = await msService.GetStringAsync(msService.MS_Url(MS_Status.Endpoint));
                if (msStatus.Parse(xmlString) == false) {
                    errMsg = "Xml Parse error";
                }
            } catch (Exception ex) {
                errMsg = ex.Message;
            }
            return errMsg;
        }

        async public Task<RecStatus> GetStatusUpdate() {            
            RecStatus recStatus = new RecStatus();
            MS_Status msStatus = new MS_Status();
            recStatus.ErrorMsg = await DoRequest(msStatus);
            if (string.IsNullOrEmpty(recStatus.ErrorMsg) ==false) {
                recStatus.Status = RecStatus.eRecording.Error;
                recStatus.WaitTime = NextPollOnError;
                return recStatus;
            }
            recStatus.NextRecording = msStatus.NextTimer;
            if (msStatus.ActiveRecordings) {
                if (actualRecording == false) {
                    // new recording detected
                    recStatus.Status = RecStatus.eRecording.Started;
                    recStatus.WaitTime = NextPollOnRecording;
                    actualRecording = true;
                    return recStatus;
                } else {
                    // on going recording
                    recStatus.Status = RecStatus.eRecording.Recording;
                    recStatus.WaitTime= NextPollOnWaiting;
                    return recStatus;
                }
            }
            // no ActiveRecordings
            recStatus.Status = RecStatus.eRecording.None;
            recStatus.WaitTime = NextPollOnWaiting;
            if (actualRecording == true) {
                // recording has ended
                recStatus.Status = RecStatus.eRecording.Stopped;
                actualRecording = false;
            }
            if (msStatus.ActiveTimers == false) {
                // we also have not timers so we have time
                recStatus.WaitTime = NextPollOnWaiting;
                return recStatus;
            }

            if (msStatus.NextTimer < NextPollOnWaiting) {
                recStatus.WaitTime = msStatus.NextTimer + 2;
            } 
            return recStatus;
        }


    }
}
