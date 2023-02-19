// See https://aka.ms/new-console-template for more information

using ModbusTCPSlave;

ModbusSlave slave = new ModbusSlave("10.0.0.4", 502);

slave.OpenConnectionAndprintMessages();

Console.ReadKey();
