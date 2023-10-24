# Local LLM - Quantized for less RAM

## References

https://huggingface.co/TheBloke/CodeLlama-13B-GGUF

https://www.youtube.com/watch?v=rZz5AORu8zE

## Usage on Windows - Quick start (for Unix, use the .sh scripts)

Open a command prompt.

Create a Python environment, to be able to install dependencies without interfering with other Python projects on the same machine:

```
create_env.bat

where Python

env\Scripts\python -v
```
- output: should output the location and version of Python, at env\Scripts\python.exe.

Install and run the LLM.

- warning: this downloads the LLM which is about 4.4 GB (multiple files).

- the files are downloaded to this folder:

`dir %USERPROFILE%\.cache\huggingface\hub`

```
install.bat
go.bat
```

- a local web site launches, where you can interact with the LLM

When done, deactivate the Python environment:

```
env\Scripts\deactivate

where python
```

- output: should output the usual location of Python

## Results

### Model: mistral-7b-instruct-v0.1.Q4_K_M.gguf

- REPETITION_PENALTY = 1 (default)
- TEMPERATURE = 0.5

Prompt:

- prompt sent to LLM: (the extra formatting like `<s>[INST]` is added programatically)

```
 <s>[INST] 
Generate a summary of the actions performed by User, as described in this DOT graph:

digraph G {
User -> MySection_1 [label="renamed from My Cars to My Favourite Cars"]
User -> MySection_0 [label="Removed"]
User -> MySection_3 [label="Added"]
}
 [/INST]
```

Response:


```
 The user performed the following actions as described in the DOT graph:

1. Renamed the section "My Cars" to "My Favourite Cars".
2. Removed the section "MySection_0".
3. Added the section "MySection_3".
```

`Time taken: 0:00:11.640128s`

#### License = Apache 2.0

- Mistral 7B was released under `Apache 2.0 license` - see [Mistral 7B release](https://mistral.ai/news/announcing-mistral-7b/)
