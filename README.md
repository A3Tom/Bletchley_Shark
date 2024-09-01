# Bletchley Shark
A system designed to test encryption making &amp; breaking in real time

## Concept
This system is designed to be a constant battle of encyption and decryption over public channels, emulating how encrypted communications could be created, intercepted and re-encrypted.  
The approach for this system is to use a message broker queue to form public keys in the open air then communicate encrypted information between producers and consumers whilst having outsider intel listening to all traffic and trying to brute force crack the message log 


## Tech stack

- Message Broker: 
    - Kafka
- Producers: 
    - .Net
- Consumers:
    - .Net
- Encryption:
    - .Net
    - Python
- Datastores:
    - MongoDB
    - DynamoDB


## Objectives

### MVP

- [ ] All encryption algorithms used must be written from scratch  
    **Important restriction**: AI must only be used to understand the algorithm, not used to write **any** code at all
- [ ] All services running in docker containers
- [ ] All Producers and Consumers must be uniquely identifiable 
- [ ] All Producers and Consumers must be assigned to a team
- [ ] Producers must broadcast their availability
- [ ] Consumers must communicate with producers to form an encryption key
- [ ] Encrypted messages must be able to be exchanged and decrypted between Producers and Consumers

### Bonus Points
- [ ] Both teams must have their own HQs and their own spy intel
- [ ] Emulate radar output as communication form
- [ ] Usage of geographical coordinates to formulate communication regions
- One bonus point for any additional consumer, producers or encryption service using the following languages:
    - Python
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption

### Super Bonus Points 
- [ ] Multiple encryption methods to pick from
- [ ] A web app to display all of this visually
- One super bonus point for any additional consumer, producer or encryption service using the following languages:
    - Rust
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption
    - Java
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption
    - Scala
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption
    - NodeJS
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption
    - C++  
        - [ ] Producer
        - [ ] Consumer
        - [ ] Encryption
- One super bonus point for each of the implemented encryption algorithms. One point per implementation, per language.
    - [ ] Single XOR encrypt
    - [ ] Caeser Cipher
    - [ ] AES-128
    - [ ] AES-192
    - [ ] AES-256
    - [ ] RSA

## Conceptual overview

![conceptual-overview](/resources/conceptual-architecture.jpg)

## Getting Started



## Acknowlegements


