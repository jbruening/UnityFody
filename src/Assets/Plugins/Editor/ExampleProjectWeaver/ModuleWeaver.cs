using UnityEngine;
using System.Collections;
using Mono.Cecil;

public class ModuleWeaver
{
    public ModuleDefinition ModuleDefinition { get; set; }

    public void Execute()
    {
        //Debug.Log("Executing module weaver for " + ModuleDefinition.Assembly.FullName);
    }
}
