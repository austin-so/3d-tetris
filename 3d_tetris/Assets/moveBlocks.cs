using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlocks : MonoBehaviour
{

    GameManager gm = new GameManager();
    private static GameObject block;

    public void W_move(){

        block = gm.getBlock();
        block.transform.position = new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z+1);

        print("W presseds");
    }

    public void A_move(){
        
        block = gm.getBlock();
        block.transform.position = new Vector3(block.transform.position.x-1, block.transform.position.y, block.transform.position.z);

        print("A presseds");
    }

     public void S_move(){

        block = gm.getBlock();
        block.transform.position = new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z-1);

        print("S presseds");
    }

     public void D_move(){
         
        block = gm.getBlock();
        block.transform.position = new Vector3(block.transform.position.x+1, block.transform.position.y, block.transform.position.z);

        print("D presseds");
    }

    public void drop(){
         
        block = gm.getBlock();
        block.transform.position = new Vector3(block.transform.position.x, block.transform.position.y-1, block.transform.position.z);

        print("drop");
    }
}
