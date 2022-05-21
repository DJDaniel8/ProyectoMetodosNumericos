function res = Gauss(b, a, error)
x1 = 0; x2 = 0; x3 = 0;
x1a = 0; x2a = 0; x3a = 0;
x1e = 0; x2e = 0; x3e = 0;
res = [x1, x2, x3, 0 0 0];
continuar = 1;
while(continuar == 1)
   x1a = x1; x2a = x2; x3a = x3;
   x1 = (b(1) - (a(1,2)*x2) - (a(1,3)*x3)) / a(1,1); 
   x2 = (b(2) - (a(2,1)*x1) - (a(2,3)*x3)) / a(2,2);
   x3 = (b(3) - (a(3,1)*x1) - (a(3,2)*x2)) / a(3,3);
   
   x1e = abs(((x1 - x1a)/x1))*100;
   x2e = abs(((x2 - x2a)/x2)) *100;
   x3e = abs(((x3 - x3a)/x3))*100;
   
   if(x1e < error && x2e < error && x3e < error)
      continuar = 0; 
   end
      
   res = [res ; [x1 x2 x3 x1e x2e x3e]];
end

