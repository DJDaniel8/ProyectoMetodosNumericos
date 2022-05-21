function d = Graficas(funciones)
d = size(funciones);
for i = 1:d(1)
    fplot(str2func(['@(x)',char(funciones(i,1))]), char(strcat(funciones(i,2),funciones(i,3),funciones(i,4))));
    hold on;
end
hold off;
grid on;
ax = gca;
ax.XAxisLocation = 'origin';
ax.YAxisLocation = 'origin';
xlim([-10 10]);
ylim([-10 10]);
end 