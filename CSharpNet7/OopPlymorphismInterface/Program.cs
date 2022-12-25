
using OopPlymorphismInterface;

SomeFile some = new SomeFile();
some.ReadFile();
some.WriteTextFile();
some.WriteBinaryFile();
((IBinaryFile)some).ShowInfo();
(some as IBinaryFile).ShowInfo();

//=====================
ManyFile many = new ManyFile();
many.WriteBinaryFile();
(many as IBinaryFile).ShowInfo();
(many as IBinaryFile).ReadFile();

many.WriteTextFile();
((ITextFile)many).ReadFile();

//=====================

IBinaryFile bf = new SomeFile();
bf.ShowInfo(); 
bf.ReadFile();
bf.WriteBinaryFile();

bf = new ManyFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();
