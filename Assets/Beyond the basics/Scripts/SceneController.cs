using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public List<Shape> gameShapes;
    // declare a dictionary with string and shape
    public Dictionary<string, Shape> shapesDictionary;

    private void Start()
    {
        // initialize dictionary
        shapesDictionary = new Dictionary<string, Shape>();

        // add values to dictionary from gameShapes
        foreach (Shape sh in gameShapes)
        {
            shapesDictionary.Add(sh.Name, sh);
        }
    }

    // SetRedByName with a string shapeName
    private void SetRedByName(string shapeName)
    {
        shapesDictionary[shapeName].SetColor(Color.red);
    }

    private void SetCyanByName(string shapeName)
    {
        shapesDictionary[shapeName].SetColor(Color.cyan);
    }

    // Update to change color with S or C
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SetRedByName("Square");

        if (Input.GetKeyDown(KeyCode.C))
            SetCyanByName("Circle");

        if (Input.GetKeyDown(KeyCode.L))
            ListExample();
    }

    private void ListExample()
    {
        string[] shapes = { "circle", "square", "triangle", "octagon" };
        List<string> moreShapes;

        moreShapes = new List<string> { "circle", "square", "triangle", "octagon" };
        moreShapes.Add("rectangle");
        moreShapes.Insert(0, "diamond");
        moreShapes.Sort();

        for (int i = 0; i < moreShapes.Count; i++)
        {
            moreShapes[i] = moreShapes[i].ToUpper();
            Debug.Log(moreShapes[i]);
        }

        Shape octagon = gameShapes.Find(sh => sh.Name == "Octagon");
        octagon.Name = octagon.Name.ToUpper();
        Debug.Log(octagon.Name);
        octagon.SetColor(Color.red);

        Shape circle = gameShapes.Find(sh => sh.Name == "Circle");
        circle.SetColor(Color.yellow);
    }
}
