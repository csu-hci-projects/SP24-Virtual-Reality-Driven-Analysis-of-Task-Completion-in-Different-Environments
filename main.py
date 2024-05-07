from typing import Final
import os
from dotenv import load_dotenv
from discord import Intents, Client, Message
from responces import get_response

load_dotenv()
TOKEN: Final[str] = os.getenv('DISCORD_TOKEN')

#bot set up 
intents: Intents = Intents.default()
intents.message_content = True #NOQA
client: Client = Client(intents=intents)

async def send_message(message: Message, user_msg: str) -> None:
    if not user_msg:
        print('intents not endabled right')
        return

    if is_private := user_msg[0] == '?':
        user_msg = user_msg[1:]

    try:
        responce: str = get_response(user_msg)
        await message.author.send(responce) if is_private else await(message.channel.send(responce))
    except Exception as e:
        print(e)

# handle start up for bot
@client.event
async def on_ready() -> None:
    print(f'{client.user} is now running')

#handle incoming messages
@client.event
async def on_message(message: Message) -> None:
    if message.author == client.user:
        return

    username: str = str(message.author)
    usr_msg: str = message.content
    channel: str = str(message.channel)
    
    print(f'[{channel}] {username}: "{usr_msg}"')

    await send_message(message, usr_msg)

# main entry pt

def main() -> None:
    client.run(token=TOKEN)

if __name__ == '__main__':
    main()
