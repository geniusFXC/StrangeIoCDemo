using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1Context : MVCSContext {

	public Demo1Context(MonoBehaviour view) : base(view) { }
    //进行绑定映射
    protected override void mapBindings()
    {
        base.mapBindings();

        //model

        //service

        //command

        //创建一个StartCommand
        
    }
}
