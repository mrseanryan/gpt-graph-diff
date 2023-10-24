HF_PROJECT = "TheBloke/Mistral-7B-Instruct-v0.1-GGUF"

MODEL_FILE__MISTRAL_7B__Q4_K_M = "mistral-7b-instruct-v0.1.Q4_K_M.gguf"
MODEL_FILE__MISTRAL_7B__Q4_K_M__MAX_TOKENS = 512 # max??

ACTIVE_MODEL_FILE = MODEL_FILE__MISTRAL_7B__Q4_K_M
MAX_NEW_TOKENS = MODEL_FILE__MISTRAL_7B__Q4_K_M__MAX_TOKENS

MODEL_TYPE = "mistral"

GPU_LAYERS = 31 # 0 means 'no GPU' - if GPU try 50 or less - then probably need ctransformers[cuda] instead of ctransformers
#
# If too high - can actually be slower! - see https://www.reddit.com/r/LocalLLaMA/comments/14kt3hz/nvidia_user_make_sure_you_dont_offload_too_many/
# - depends on graphics card + the model
#
# Times for 24GB [only 8GB dedicated which seems to be the limit!] NVIDIA card with model MODEL_FILE__MISTRAL_7B__Q4_K_M:
# - note in Task manager, the Shared GPU memory should stay low, else is slower.
# TODO xxx

# getting GPU to work was tricky - ran this on command line:
# pip install "ctransformers[cuda]>=0.2.24"

REPETITION_PENALTY = 1 # 1.13 - range is 1 (no penalty, default) to 'infinity'

# TEMPERATURE = 0.5
# - with Mistral-7B:
# -- Possibly setting Temp = 1 (not 0.5) adds more details to the DOT output ....
# -- Higher temp does help with the DOT -> natural language inference (more text is generated).
TEMPERATURE = 1 # range is normally 0 (consistent) to 1 (more 'creative')
