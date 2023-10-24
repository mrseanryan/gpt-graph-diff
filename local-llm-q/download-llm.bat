pip3 install huggingface-hub>=0.17.1

REM huggingface-cli download TheBloke/Mistral-7B-Instruct-v0.1-GGUF mistral-7b-instruct-v0.1.Q4_K_M.gguf --local-dir . --local-dir-use-symlinks False

huggingface-cli download TheBloke/Mistral-7B-Instruct-v0.1-GGUF --local-dir . --local-dir-use-symlinks False --include=*q4_K_M*gguf*
