using Strategy;
Twitch tw = new Twitch(new ViewPanel());
tw.DoIt();
tw.st = new Stream();
tw.DoIt();
Youtube yt = new Youtube(new ShowChat());
yt.DoIt();
yt.st = new Stream();
yt.DoIt();
