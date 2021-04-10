using System;

namespace Cola
{
    class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public void Encolar(int num){
            Console.WriteLine("Encolando nodo...");
            Nodo nodo = new Nodo(num);
            nodo.Siguiente = null;
            
            if(this.primero == null){
                this.primero = nodo;
                this.ultimo = this.primero;
                Console.WriteLine("Nodo insertado.\n");                
                return;
            } 
            
            this.ultimo.Siguiente = nodo;
            this.ultimo = nodo;     
            Console.WriteLine("Nodo insertado.\n");                            
        }

         public void Mostrar(){
            Console.WriteLine("Mostrando lista...");
            
            Nodo nodo = this.primero;

            while(nodo != null){
                Console.WriteLine(nodo.Num);
                nodo = nodo.Siguiente;
            }

            Console.WriteLine();
        }

        public void Desencolar(){
            if(this.primero == null){
                Console.WriteLine("Sin elementos para desencolar.\n");
                return;
            }
            Console.WriteLine("Desencolando...");
            Nodo n = this.primero;
            this.primero = this.primero.Siguiente;
            n = null;            
        }
    }
}