from azure.servicebus import QueueService
import json

queue_service = QueueService(account_name, account_key)

def get_cpu_temp():
    tempfile = time.second
    # cpu_temp = tempfile.read()
    # tempfile.close()
    # return float(cpu_temp)/1000
    return tempfile

bus = ServiceBusService('namespace', 'key', 'owner')

bus.create_queue('processor_temp')


while True:
    try:
        reading = (datetime.time(), get_cpu_temp())
        message = Message(json.dumps(reading))
        bus.send_queue_message('processor_temp', message)
    finally:
        pass