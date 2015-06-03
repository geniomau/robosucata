#include "controle.h"
int direcao;
#int_RB
void  RB_isr(void) 
{
if( !input(PIN_B4)) printf("E");
if( !input(PIN_B5)) printf("D");
if( !input(PIN_B6)) printf("F");
if( !input(PIN_B7)) printf("T");

direcao=input_b();
if(direcao==255) printf("P");
//printf("para");
}



void main()
{

   port_b_pullups(TRUE);
   setup_timer_0(RTCC_INTERNAL|RTCC_DIV_1);
   setup_timer_1(T1_DISABLED);
   setup_timer_2(T2_DISABLED,0,1);
   setup_comparator(NC_NC_NC_NC);
   setup_vref(FALSE);
   enable_interrupts(INT_RB);
   enable_interrupts(GLOBAL);
//Setup_Oscillator parameter not selected from Intr Oscillator Config tab
   
   
   // TODO: USER CODE!!
   while(true)
   {

   
   }
}
