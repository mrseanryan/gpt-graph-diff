from gradio_client import Client

import config

client = Client(config.URL)

def send_prompt(prompt):
    print(">> " + prompt)
    return client.predict(
            prompt,	# str  in 'Message' Textbox component
            api_name="/chat"
    )
