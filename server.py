from time import sleep
from flask import Flask;
import os;
import subprocess;
import platform;

#next list: ¶
#next value: »
usersFile = "/home/Ee0Rk/mysite/clients.txt";
adminsFile = "/home/Ee0Rk/mysite/admins.txt";

admins = ["default"];
clients = ["default"];

app = Flask(__name__);

def removeDupes(list): return set(list);

def read(file):
    with open(file, "r") as fl:
        return fl.read();
           
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
    userFile = read(usersFile);
    adminFile = read(adminsFile)
    str = f"{adminFile}¶{userFile}";
    return str;
#####################################ADMIN
@app.route('/admin/<ip>')
def admin_login(ip):
    global admins;
    
    with open(adminsFile) as f2:
        admins = f2.read().split("»");

    if (ip in admins and ip != "default"):
        return "fail";
    else:
        admins.append(ip);
        admins = removeDupes(admins);
        with open(adminsFile, "w") as file:
            str = "";
            for line in admins:
                str += line+"»";
            file.write(str);
        return "success";

@app.route('/admin/<ip>/disconnect')
def admin_logout(ip):
    global admins;
    
    with open(adminsFile) as f2:
        admins = f2.read().split("»");

    if (ip not in admins and ip != "default"):
        return "fail";
    else:
        admins.remove(ip);
        admins = removeDupes(admins);
        with open(adminsFile, "w") as file:
            str = "";
            for line in admins:
                str += line+"»";
            file.write(str);
        return "success";
######################################CLIENT
@app.route('/client/<ip>')
def client_login(ip):
    global clients;
    
    with open(usersFile) as f2:
        clients = f2.read().split("»");

    if (ip in clients and ip != "default"):
        return "fail";
    else:
        clients.append(ip);
        clients = removeDupes(clients);
        with open(usersFile, "w") as file:
            str = "";
            for line in clients:
                str += line+"»";
            file.write(str);
        return "success";
@app.route('/client/<ip>/disconnect')
def client_logout(ip):
    global clients;
    
    with open(usersFile) as f2:
        clients = f2.read().split("»");

    if (ip not in clients and ip != "default"):
        return "fail";
    else:
        clients.remove(ip);
        clients = removeDupes(clients);
        with open(usersFile, "w") as file:
            str = "";
            for line in clients:
                str += line+"»";    
            file.write(str);
        return "success";

if __name__ == '__main__':
    if (not os.File.exists(usersFile)):
        os.File.create(usersFile)
    if (not os.File.exists(adminsFile)):
        os.File.create(adminsFile)

    with open(usersFile) as f1:
        clients = f1.read().split("»");
    with open(adminsFile) as f2:
        admins = f2.read().split("»");

    #p = Process(_ping).start();
    app.run(port=45698);
