from msilib.schema import File
from time import sleep
from venv import create;
from flask import Flask;
from multiprocessing import Process;
import os;
import subprocess;
import platform;

#next kind: ¶ U+00B6
#next value: ► U+25BC
#next list: ▼ U+25BA
#value start: « U+00AB
#value end: » U+00BB

usersFile = "/home/Ee0Rk/mysite/client.txt";
incUsersFile = "/home/Ee0Rk/mysite/discClients.txt";
discUsersFile = "/home/Ee0Rk/mysite/discClients.txt";

admins = ["default"];
clients = ["default"];

app = Flask(__name__);

def removeDupes(list): return set(list);

def readResponse(response):
    reading_item = False;
    item_index = 0;
    list_index = 0;
    section_index = 0;
    item_string = "";

    items = [];
    sections = [];
    lists = [];

    for letter in response:
        if (letter == "«"):
            item_string = "";
            reading_item = True;
            continue;
        elif (letter == "»"):
            items.append(item_string);
            item_string = "";
            reading_item = False;
            continue;
        elif (letter == "►"):
            item_index+=1;
            continue;
        elif (letter == "▼"):
            sections.append(items);
            items = [];
            section_index+=1;
            continue;
        elif (letter == "¶"):
            lists.append(sections);
            sections = [];
            list_index+=1;
            continue;
        else:
            if (reading_item):
                item_string += letter;

        return lists;

def writeResponse(ents):
    str = ""
    subitemIndex = 0
    itemIndex = 0
    listIndex = 0
    for lists in ents:
        listIndex += 1
        if ((listIndex > 0) & (listIndex != (ents.Length - 1))):
            str += "¶"
        for items in lists:
            itemIndex += 1
            if ((itemIndex > 0) & (itemIndex != (lists.Length - 1))):
                str += "▼"
            for subitem in items:
                subitemIndex += 1
                str += "«{}»".format(subitem)
                if ((subitemIndex > 0) & (subitemIndex != (items.Length - 1))):
                    str += "►"
    return str

def read(file, raw):
    if (raw):
        with open(file, "r") as file:
            return file.read();
    else:
        with open(file, "r") as file:
            return file.read().split("▼");
           
def check_address(ip_address):
    if ip_address.count('.') != 3 or not all(ip_byte.isdigit() and int(ip_byte) < 255 for ip_byte in ip_address.split('.')):
        return False
    else: return True

def _ping():
    while True:
        global admins;
        global clients;
        t_admins=[];
        t_clients=[];
        d_admins=[];
        d_clients=[];
        i_admins=[];
        i_clients=[];
        for line in admins:
            if(check_address(line)):
                param = '-n' if platform.system().lower()=='windows' else '-c'
                command = ['ping', param, '1', line]
                response =  subprocess.call(command) == 0
                if (response):
                    t_admins.append(line);
                else:
                    d_admins.append(line);
            else:
                i_admins.append(line);
        for line in clients:
            if(check_address(line)):
                param = '-n' if platform.system().lower()=='windows' else '-c'
                command = ['ping', param, '1', line]
                response =  subprocess.call(command) == 0
                if (response):
                    t_clients.append(line);
                else:
                    d_clients.append(line);
            else:
                i_clients.append(line);


        sleep(10);


#####################################HOME
@app.route('/')
def home():
    file = read(usersFile, True);
    return file;
#####################################ADMIN
@app.route('/admin/<ip>')
def admin_login(ip):
    global admins;
    global clients;
    if (ip in admins and ip != "default"):
        return "fail\n" + str(clients) + "\n" + str(admins);
    else:
        admins.append(ip);
        admins = removeDupes(admins);
        with open("/home/Ee0Rk/mysite/admins.txt", "w") as file:
            for line in admins:
                file.write(line+"\n");  
        return "success\n" + str(clients) + "\n" + str(admins);

@app.route('/admin/<ip>/disconnect')
def admin_logout(ip):
    global admins;
    global clients;
    if (ip in admins and ip != "default"):
        admins.remove(ip);
        admins = removeDupes(admins);
        with open("/home/Ee0Rk/mysite/admins.txt", "w") as file:
            for line in admins:
                file.write(line+"\n");
        return "success";
    else:
        return "fail " + ip;
######################################CLIENT
@app.route('/client/<ip>')
def client_login(ip):
    global clients;
    if (ip in clients and ip != "default"):
        return "fail";
    else:
        clients.append(ip);
        clients = removeDupes(clients);
        with open("/home/Ee0Rk/mysite/clients.txt", "w") as file:
            for line in clients:
                file.write(line+"\n");
        return "success";
@app.route('/client/<ip>/disconnect')
def client_logout(ip):
    global clients;
    if (ip in clients and ip != "default"):
        clients.remove(ip);
        clients = removeDupes(clients);
        with open("/home/Ee0Rk/mysite/clients.txt", "w") as file:
            for line in clients:
                file.write(line+"\n");
        return "success";
    else:
        return "fail";

if __name__ == '__main__':
    if (not os.File.exists(usersFile)):
        os.File.create(usersFile)
    if (not os.File.exists(incUsersFile)):
        os.File.create(incUsersFile)
    if (not os.File.exists(discUsersFile)):
        os.File.create(discUsersFile)
    p = Process(_ping).start();
    app.run(port=45698);
