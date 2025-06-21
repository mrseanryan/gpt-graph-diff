# gpt-graph-diff
Use an LLM to describe a difference graph between versions of a compositional document.

The LLM generates a summary of user operations, for audit or for source control commit message.

## local/self-hosted LLM 

A self-hosted LLM seems a better proof of concept that simply using a public service like Open AI.

There is a quantized PoC [here](./local-llm-q/README.md)
