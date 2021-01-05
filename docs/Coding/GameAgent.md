# GameAgent

*Characters*. 

## Interfaces

### Main

#### ISave\<T>

Stores data\<T> from agents can be stored in save data. By data we can define things like: *transform*, *velocity*, *inventory*. 

#### IPausable

Agents can be paused. Implements additional layer on TimeScale.

#### IRestartable
Agents can be returned too their base state.

### Additional

Interfaces that can, but don't have to be on GameAgent.

#### IControllableAgents 

Agents that can be controlled by **IController** (*interface defining object that handles controllers*). 

#### IDamageable

Agents that have health and can be destroyed.

