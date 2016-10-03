# XModem Protocol
## Implementation of the XMODEM Protocol compatible with .NET written in C#.

Supports XModem, XModem-1k & XModem-CRC.

This library can be used to send or receive bytes across a serial line.

### Properties

* _**Data**_  
 * Read/Write  
 Accepts, and returns a collection of type _IEnumerable&lt;byte&gt;_. This is the data that will be sent or the data that was received.

* _**Communicator**_
 * Write Only  
 Accepts an instance of a class that implements the _ICommunicator_ interface. This object will be used to facilitate the transfer of bytes.

* _**Port**_
 * Write Only  
 Accepts an instance of the _SerialPort_ class. This will be passed to a generic object that implements the _ICommunicator_ interface.

* _**Options**_
 * Write Only  
 Accepts an instance of a class that implements the _IXModemProtocolOptions_ interface. This contains the bytes that _XModemCommunicator_ will use to facilitate transfer along with some other options to customize how _XModemCommunicator_ operates.
 
### Methods
* _**Send**_  
 Send Operation.

* _**Receive**_  
 Receive Operation.

* _**CancelOperation**_  
 Cancel Operation.

### Events supported
* _**ModeUpdated**_  
 Fires when the mode of _XModemCommunicator_ is updated.

* _**StateUpdated**_  
 Fires when the state of _XModemCommunicator_ is updated.

* _**PacketsBuilt**_  
 Fires when _XModemCommunicator_ builds packets.

* _**PacketToSend**_  
 Fires when _XModemCommunicator_ is ready to send a packet. A blocking method will prevent packet from being sent.

* _**PacketReceived**_  
 Fires when _XModemCommunicator_ receives a packet.

* _**Aborted**_  
 Fires if the operation is aborted. Instance will not return to being idle until event completes.

* _**Completed**_  
 Fires when the operation completes successfully. Instance will not return to being idle until event completes.

* _**OperationPending**_  
 Fires before the operation begins. The return value is a bool which determines if operation will run or not. _**Will not fire if Data contains no bytes, and performing send operation.**_

### Author
Peter T. Owens-Finch  
powensfinch@gmail.com
