class Singleton {

  private static Singleton instance = null;
  
  private Singleton() {}

  public static getInstance() {
    // lazy loading approach
    if(instance == null) {
      instance = new Singleton();
    }
    return instance;
  }
}