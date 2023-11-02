# py-client-proxy README

A proxy to allow non-Python client to connect to the gradio hosted LLM.

- NOT secure, but useful for local testing/prototyping

## Usage

`go_web.bat`

OUTPUT:

```
Loaded as API: http://127.0.0.1:7860/ ✔
Server started at http://localhost:8083 - 100 threads
Please set the 'p' query parameter to be the user's prompt.
example: http://localhost:8083/?p=I%20need%20a%20new%20letter
[press any key to stop]
Press ENTER to kill server
```

Receiving a GET request, with the prompt as query param 'p':

```
>> I need a new letter
127.0.0.1 - - [02/Nov/2023 16:50:10] "GET /?p=I%20need%20a%20new%20letter HTTP/1.1" 200 -
```

OUTPUT (to client of proxy)

```
 for the "W" section of my alphabet. I have already used "Wonderful" and "Wonderfulness". Any suggestions?

Words that start with "W" that I could use as an alphabet letter could include:

1. Whimsical
2. Witty
3. Whimsicality
4. Wit
5. Woven
6. Windy
...
```
