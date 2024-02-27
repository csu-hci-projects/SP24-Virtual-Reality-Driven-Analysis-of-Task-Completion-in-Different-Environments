

def get_response(user_input: str) -> str:
    lowered: str = user_input.lower()


## this is where our responce loic will go
    if lowered == '':
        return 'well, you dont talk'
    elif 'hello' in lowered:
        return "Hhello how are we today "
    else:
        return 'temp for base case responce'