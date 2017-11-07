namespace Game {

  public class Entity {
    private life;
    private attack;
    private defense;

    //Constructor
    public Entity(int life) {
      this.life = life;
    }

    //Getter and Setters
    protected int GetLife() {
      return life;
    }

    protected int GetAttack() {
      return attack;
    }

    protected int GetDefense() {
      return defense;
    }

    public void SetLife(int life) {
      this.life = life;
    }

    public void SetAttack(int attack) {
      this.attack = attack;
    }

    public void SetDefense(int defense) {
      this.defense = defense;
    }
  }
}
