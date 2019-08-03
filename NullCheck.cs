using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullCheck  {

    public static void IsNull(params Object[] objects)
    {
        string nullObjNames="";
        List<Object> nullObjects = new List<Object>();
        foreach (var obj in objects)
        {
            if (obj == null)
            {
                nullObjects.Add(obj);
            }
        }
        foreach (var obj in nullObjects)
        {
            nullObjNames += obj.name + "  ";
        }
        if(nullObjNames == "")
        {
            Debug.Log("No null values found");
            return;
        }
        Debug.Log(nullObjNames);

    }

	
}
