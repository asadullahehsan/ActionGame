using ActionGame.Implementations.Characters;
using ActionGame.Implementations.Weapons;

var king = new King();
var queen = new Queen();
var knight = new Knight();
var troll = new Troll();

king.Fight();
king.SetWeapon(new Sword());
king.Fight();

queen.Fight();

knight.Fight();
knight.SetWeapon(new Axe());
knight.Fight();

troll.Fight();

