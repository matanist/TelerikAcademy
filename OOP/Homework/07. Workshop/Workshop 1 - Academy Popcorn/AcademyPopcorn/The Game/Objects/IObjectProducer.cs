﻿using System.Collections.Generic;

namespace AcademyPopcorn
{
    public interface IObjectProducer
    {
        IEnumerable<GameObject> ProduceObjects(int col);
    }
}
