from flask import Flask

admins = ["default"]
clients = ["default"]

app = Flask(__name__)

def removeDupes(list):
    return set(list)

#####################################HOME
@app.route('/')
def home():
    global admins
    global clients
    admins=[]
    clients=[]
    with open("/home/Ee0Rk/mysite/admins.txt", "r") as file:
            for line in file.readlines():
                admins.append(line)
    with open("/home/Ee0Rk/mysite/clients.txt", "r") as file:
            for line in file.readlines():
                clients.append(line)
    return str(clients) + "\n" + str(admins)

#####################################ADMIN
@app.route('/admin/<ip>')
def admin_login(ip):
    global admins
    global clients
    if (ip in clients):
        return "fail\n" + str(clients) + "\n" + str(admins)
    else:
        admins.append(ip)
        admins = removeDupes(admins)
        with open("/home/Ee0Rk/mysite/admins.txt", "w") as file:
            for line in admins:
                file.write(line+"\n")
        return "success\n" + str(clients) + "\n" + str(admins)
    
@app.route('/admin/<ip>/disconnect')
def admin_logout(ip):
    global admins
    global clients
    if (ip in admins and ip != "default"):
        admins.remove(ip)
        admins = removeDupes(admins)
        with open("/home/Ee0Rk/mysite/admins.txt", "w") as file:
            for line in admins:
                file.write(line+"\n")
        return "success"
    else:
        return "fail " + ip

######################################CLIENT
@app.route('/client/<ip>')
def client_login(ip):
    global clients
    if (ip in clients):
        return "fail"
    else:
        clients.append(ip)  
        clients = removeDupes(clients)
        with open("/home/Ee0Rk/mysite/clients.txt", "w") as file:
            for line in clients:
                file.write(line+"\n")
        return "success"
@app.route('/client/<ip>/disconnect')
def client_logout(ip):
    global clients
    if (ip in clients):
        clients.remove(ip)
        clients = removeDupes(clients)
        with open("/home/Ee0Rk/mysite/clients.txt", "w") as file:
            for line in clients:
                file.write(line+"\n")
        return "success"
    else:
        return "fail"

if __name__ == '__main__':
    app.run(port=45698)