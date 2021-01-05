# Game Agent
Defines object in the game. 

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
Interfaces that can, but don't have to be on GameEntity.

#### IUsable\<T> 
Can be used by GameAgent.

#### IDamageable
Objects that have health and can be destroyed.
> Wood plank that can be cut with axe.
