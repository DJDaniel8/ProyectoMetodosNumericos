function xy = Intersecciones(f1,f2)
x = -10:0.02:10;
f1 = str2func(strcat('@(x)',char(f1)));
f2 = str2func(strcat('@(x)',char(f2)));
y1 = f1(x);
y2 = f2(x);
P = InterX([x;y1],[x;y2]);
xy = P;
fplot(f1,[-10,10]);
hold on;
fplot(f2,[-10,10]);
grid on;
hold off;
ax = gca;
ax.XAxisLocation = 'origin';
ax.YAxisLocation = 'origin';
xlim([-10 10]);
ylim([-10 10]);

end