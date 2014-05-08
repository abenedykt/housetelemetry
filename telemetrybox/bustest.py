from azure.servicebus import *
import json


def get_cpu_temp():
    tempfile = open("/sys/class/thermal/thermal_zone0/temp")
    cpu_temp = tempfile.read()
    tempfile.close()
    return float(cpu_temp)/1000


bus = ServiceBusService('namespace', 'key', 'owner')

bus.create_queue('processor_temp')


while True:
    try:
        reading = (datetime.time(), get_cpu_temp())
        message = Message(json.dumps(reading))
        bus.send_queue_message('processor_temp', message)
    finally:
        pass