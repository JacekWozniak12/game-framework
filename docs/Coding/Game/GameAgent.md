# Game Agent
Defines characters in the game. 

## Interfaces
Defines all interfaces that are both implemented and suggested to implement.
> Implementation examples

### Main
#### ISave\<T>
Stores data\<T> from agents can be stored in save data. By data we can define things like: *transform*, *velocity*, *inventory*. 
> Save systems

#### IPausable
Agents can be paused. Implements additional layer on Update() / FixedUpdate() / LateUpdate();
> Pause on Pause Menu button.

#### ICustomTimeScale
Implements additional layer on TimeScale, that can be changed.
> Slow motion effect.

### Additional
Interfaces that are suggested for, but don't have to be on GameAgent.

#### IControllableAgents 
Agents that can be controlled by **IController** (*interface defining object that handles controllers*). 

#### IDamageable
Agents that have health and can be destroyed.
> Zombie that can be killed with weapon.


