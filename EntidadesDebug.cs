using System.Collections;
using UnityEngine;

public class EntidadesDebug : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);

        // Testing Get

        //var tailDrops = Entidades.Get<GridData>(typeof(TailDrop), typeof(GridData));
        //for (int i = 0; i < tailDrops.Length; i += 1)
        //    Debug.Log($"TailDrops length {tailDrops.Length} and name {tailDrops[i].name}");

        //var snake = Entidades.Get<Snake>();
        //Debug.Log($"Snake length {snake.Length} at {Time.time}");
        //foreach (var i in snake)
        //    Debug.Log($"{i.name} Type: {i.GetType()} at {Time.time}");

        //var tails = Entidades.Get<Tail>();
        //Debug.Log($"Tails length {tails.Length} at {Time.time}");
        //for (int i = 0; i < tails.Length; i += 1)
        //    Debug.Log($"[{i}] {tails[i].name} Type: {tails[i].GetType()} at {Time.time}");

        //// Testing Remove

        //Entidades.Remove(snake[0].GetInstanceID(), snake[0]);
        //snake = Entidades.Get<Snake>();
        //Debug.Log($"Snake length {snake.Length} at {Time.time}");
        //foreach (var i in snake)
        //    Debug.Log($"{i.name} Type: {i.GetType()} at {Time.time}");

        //Entidades.Remove(tails[0].GetInstanceID(), tails[0]);
        //Entidades.Remove(tails[1].GetInstanceID(), tails[1]);
        //tails = Entidades.Get<Tail>();
        //Debug.Log($"Tails length {tails.Length} at {Time.time}");
        //foreach (var tail in tails)
        //    Debug.Log($"{tail.name} Type: {tail.GetType()} at {Time.time}");
    }
}
