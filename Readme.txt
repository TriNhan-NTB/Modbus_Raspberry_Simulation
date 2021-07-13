Modbus COM1 <==> COM2
Giao tiếp máy tính COM3 <==> COM4

copy main.txt paste proteus complier

copy all folder and file in Lib paste folder Debug (please open path.png)

- RTU
Open RSim
Prot:MODBUS RS232
	Port: COM2
	Baurate: 9600
	Parity: None
	Data bits: 8
	Stop bits: 1

- TCP
Open RSim
Prot:MODBUS TCP/IP
	Port: 502
- ASCII
Open modbus Slave
Connect Mode: ASCII
	Port: COM2
	Baurate: 9600
	Parity: None
	Data bits: 8
	Stop bits: 1

open Visual Studio ==> Start using COM4

run Protues
