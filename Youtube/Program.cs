Youtuber alanzoka = new();

for (int i = 0; i < 10; i++)
{
    var subs = new Subscriber();
    alanzoka.em.Subscribe(subs);
}

alanzoka.em.Subscribe( new Hater());
alanzoka.Publish();