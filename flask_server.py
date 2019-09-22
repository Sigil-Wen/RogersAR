from flask import Flask, request
from time import sleep

app = Flask(__name__) #create the Flask app

@app.route('/query')
def query_example():
    device = request.args.get('device') #if key doesn't exist, returns None
    print(device)
    if device == 1:
        print("yeetus")
    if device == 2:
        print("thy")
    if device == 3:
        print("fetus")
    else:
        print("Invalid device code")
    return '''<h1>Device Req recieved: {}</h1>'''.format(device)

if __name__ == '__main__':
    app.run(host="0.0.0.0",port=5000) #run app in debug mode on port 5000