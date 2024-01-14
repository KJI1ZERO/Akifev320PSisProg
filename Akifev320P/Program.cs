using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Akifev320P;

Peasant ps1 = new Peasant();
Support Support = new Support();
Footman footman = new Footman();

ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();

Support.Heal(ps1);
ps1.ShowInfo();


