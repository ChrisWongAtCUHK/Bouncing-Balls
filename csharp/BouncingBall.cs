public class BouncingBall
{

    public static int bouncingBall(double h, double bounce, double window)
    {
        if (h * bounce <= window || bounce == 1) return -1;     // for exceptional cases
        int falling = 0;                                        // counter for falling seen
        int bouncing = 0;                                       // counter for bouncing seen

        do
        {
            if (h > window) falling++;
            h *= bounce;
            if (h > window) bouncing++;
        } while (h > window);

        return falling + bouncing;
    }
}

