﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish2 : MonoBehaviour
{
      private void OnTriggerEnter(Collider other){
          if(other.gameObject.name=="player")
          {
              SceneManager.LoadScene("Final");
          }


    }}