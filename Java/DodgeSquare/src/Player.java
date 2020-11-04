import java.awt.*;
import java.util.Random;

public class Player extends GameObject
{
    Random r = new Random();
    Handler handler;

    public Player(int x, int y, ID id, Handler handler)
    {
        super(x, y, id);
        this.handler = handler;
    }
    public Rectangle getBounds()
    {
        return new Rectangle(x,y,32,32);
    }
    public void tick()
    {
        x += speedX;
        y += speedY;
        x = Game.clamp(x, 0,Game.WIDTH - 40);
        y = Game.clamp(y, 0,Game.HEIGHT - 60);
        collision();
    }
    private void collision()
    {
        for(int i=0; i<handler.object.size(); i++)
        {
            GameObject tempObject = handler.object.get(i);
            if(tempObject.getId() == ID.BasicEnemy)
            {
                if(getBounds().intersects(tempObject.getBounds()))
                {
                    HealthBar.HEALTH -= 2;
                    if(HealthBar.HEALTH == 0)
                    {
                        System.out.println("YOU LOST");
                    }
                }
            }
        }
    }
    public void render(Graphics g)
    {
        g.setColor(Color.WHITE);
        g.fillRect(x,y,32,32);
    }
}
