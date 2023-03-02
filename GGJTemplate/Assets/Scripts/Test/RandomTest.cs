using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    struct test
    {
        public int a;
    }

    private void Start()
    {
        List<test> test = new List<test>();
        for (int i = 0; i < 10; i++)
        {
            test.Add(new test() { a = i });
        }

        var match = test.Where(t => t.a == 5);
        var index = test.IndexOf(match.First());
        var tmp = test[test.IndexOf(match.First())];
        tmp.a = 12;
        if (match.Any())
        {
            Debug.Log(test[index].a);
        }
        //foreach (var item in test)
        //{
        //    Debug.Log(item.a);
        //}
    }
}
