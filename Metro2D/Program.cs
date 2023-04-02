using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace Metro2D
{
  class Program
  {
    static void Main()
    {
      VideoMode v = new VideoMode();
      v.Height = 720;
      v.Width = 1280;

      RenderWindow r = new RenderWindow(v, "Test Hello");

      r.Closed += OnClosed;
      r.KeyPressed += OnKeyPressed;
      r.MouseButtonPressed += OnMousePressed;
      r.MouseButtonReleased += OnMouseReleased;
      RectangleShape rect = new RectangleShape(new Vector2f(20,20));
      
      while(r.IsOpen) {
        r.DispatchEvents();
        r.Clear();

        r.Draw(rect);

        r.Display();
      }
    }

    static void OnClosed(object sender, EventArgs e)
    {
      var window = (RenderWindow)sender;
      window.Close();
    }
    static void OnKeyPressed(object sender, KeyEventArgs e)
    {
    }

    static void OnMousePressed(object sender, MouseButtonEventArgs e)
    {
    }

    static void OnMouseReleased(object sender, MouseButtonEventArgs e)
    {
    }

  }
}