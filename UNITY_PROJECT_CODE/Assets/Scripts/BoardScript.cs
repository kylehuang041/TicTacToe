using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    int spriteIdx = -1;

    public int ChangeToken() {
        return ++spriteIdx % 2;
    }
}
