# ism7mqtt

Get all statistics and values from your Wolf ISM7 and send them to an mqtt server without using the smartset cloud or scraping the smartset UI. It connects directly to your ism7.

## How?

Run ism7parameter on a Windows machine where Wolf SmartSet is installed and was connected to your ism7 at least once. This will create a parameter.txt file which is needed for ism7mqtt.

Run ism7mqtt on any machine which can connect to your ism7 and an mqtt server.

```
ism7mqtt -m <mqttserver> -i <ism7 ip/host> -p <ism7 password>
```

Do not forget to put the generated parameter.txt next to the ism7client.

## Cons

The ism7 accepts only a single connection, so you cannot use the Smartset application while ism7mqtt is running.

Currently it is not possible to send any command or configuration to the ism7 (mainly for safety reasons - it get's cold if this software breaks something).

## Protocol

The Smartset application connects to the ism7 via TCP on port 9092. There can only be one connection at a time.

### Encryption

The connection is encrypted using TLS (TLS_RSA_WITH_AES_256_CBC_SHA256) and a client certificate singed by "LuCon Root CA (direct)" is required.

### Payload

Each message starts with a six byte header (4 byte length, 2 byte type). The payload is mostly xml.

### Interpretation

The Smartset application contains 3 helpful xml files, which define the conversion, dependencies and human readable names for the data.

## Diving deeper

If you want look at all the nasty details, I recommend taking a look at [dnSpy](https://github.com/dnSpy/dnSpy/). Using this I was able to get all required information (like database password, encryption key for the XML files in the system-config folder, client certificate, etc.) and was able to patch out the certificate verification to use a mitm proxy.
