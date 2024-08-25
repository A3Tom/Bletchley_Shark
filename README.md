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
- Datastores:
    - DynamoDB


## Objectives

### MVP

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
- One bonus point for any additional consumer or producers using the following languages:
    - Python
        - [ ] Producer
        - [ ] Consumer

### Super Bonus Points 
- [ ] Multiple encryption methods to pick from
- [ ] A web app to display all of this visually
- One super bonus point for any additional consumer or producer using the following languages:
    - Rust
        - [ ] Producer
        - [ ] Consumer
    - Java
        - [ ] Producer
        - [ ] Consumer
    - Scala
        - [ ] Producer
        - [ ] Consumer
    - NodeJS
        - [ ] Producer
        - [ ] Consumer
    - C++  
        - [ ] Producer
        - [ ] Consumer
    

## Getting Started



## Acknowlegements


