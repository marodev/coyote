---
layout: reference
section: learn
title: IsRewritingUnitTests
permalink: /learn/ref/Microsoft.Coyote.Rewriting/RewritingOptions/IsRewritingUnitTests
---
# RewritingOptions.IsRewritingUnitTests property

True if rewriting of unit test methods is enabled, else false.

```csharp
public bool IsRewritingUnitTests { get; }
```

## Remarks

If unit test rewriting is enabled, Coyote will instrument the binary to run unit test methods in the scope of the Coyote testing engine. Note that this rewriting does not change the semantics of the original test. For example, if the test is sequential it will remain sequential, limiting the concurrency coverage that Coyote can achieve.

## See Also

* class [RewritingOptions](../RewritingOptionsType)
* namespace [Microsoft.Coyote.Rewriting](../RewritingOptionsType)
* assembly [Microsoft.Coyote.Test](../../MicrosoftCoyoteTestAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.Test.dll -->