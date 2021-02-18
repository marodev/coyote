# IActorRuntimeLog.OnHalt method

Invoked when the specified actor has been halted.

```csharp
public void OnHalt(ActorId id, int inboxSize)
```

| parameter | description |
| --- | --- |
| id | The id of the actor that has been halted. |
| inboxSize | Approximate size of the inbox. |

## See Also

* class [ActorId](../ActorId.md)
* interface [IActorRuntimeLog](../IActorRuntimeLog.md)
* namespace [Microsoft.Coyote.Actors](../IActorRuntimeLog.md)
* assembly [Microsoft.Coyote](../../Microsoft.Coyote.md)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->