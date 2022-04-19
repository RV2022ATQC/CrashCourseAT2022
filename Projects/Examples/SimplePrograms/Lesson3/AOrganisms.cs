﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{

    //Абстрактний клас може містити загальні методи для усіх класів нащадків
    //
    //Неможливо створити об'єкт, якщо в класі ще існують абстракції
    //для компілятора усі методи мають бути конкретизовані, не має бути жодних невизначеностей
    //Якщо ми хочемо ініціалізувати об'єкт класу нащадка, то
    //ми МУСИМО перевизначити УСІ абстрактні методи. 

    public abstract class AOrganisms
    {

        //віртуальні virtual методи можуть бути переписані\override в класах нащадках = принцип ООП поліморфізм
        public virtual string GetName() => "I'm organism";

        //абстрактні abstract методи мають бути реальізовані у класах нащадках
        public abstract void GetState();
    }
}
