using System.Collections;
using System.Collections.Generic;
using Loxodon.Framework.Data;
using UnityEngine;
using Zitga.Samples.Configuration.Scripts;

public class ConfigurationExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var service = new ServiceConfig();
        var dungeon = service.Resolve<DungeonActiveBuffConfig>();
    }

}
