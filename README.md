# MediaServerTray
Small application to monitor the recording status of the media server
One of the wishes of a user of the media server (DVBViewer) was to be able to control an LED on the recording PC. This should show when the PC was recording.
Since I was interested in this topic and I wanted to play around with the API I wrote this program for this task.

The user can start a Windows Script at the start of the recording process, after the recording process is finished and in case of an error (e.g. no connection to the media server).
All queried states are saved in a log file if desired.


