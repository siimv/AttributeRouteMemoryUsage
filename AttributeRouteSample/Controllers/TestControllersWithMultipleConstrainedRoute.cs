//using Microsoft.AspNetCore.Mvc;

//namespace AttributeRouteSample.Controllers
//{

//    [Route("{language:length(2)}/test1")]
//    [Route("{version:int}/{language:length(2)}/test1")]
//    public class Test1Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test2")]
//    [Route("{version:int}/{language:length(2)}/test2")]
//    public class Test2Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test3")]
//    [Route("{version:int}/{language:length(2)}/test3")]
//    public class Test3Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test4")]
//    [Route("{version:int}/{language:length(2)}/test4")]
//    public class Test4Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test5")]
//    [Route("{version:int}/{language:length(2)}/test5")]
//    public class Test5Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test6")]
//    [Route("{version:int}/{language:length(2)}/test6")]
//    public class Test6Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test7")]
//    [Route("{version:int}/{language:length(2)}/test7")]
//    public class Test7Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test8")]
//    [Route("{version:int}/{language:length(2)}/test8")]
//    public class Test8Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test9")]
//    [Route("{version:int}/{language:length(2)}/test9")]
//    public class Test9Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test10")]
//    [Route("{version:int}/{language:length(2)}/test10")]
//    public class Test10Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test11")]
//    [Route("{version:int}/{language:length(2)}/test11")]
//    public class Test11Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test12")]
//    [Route("{version:int}/{language:length(2)}/test12")]
//    public class Test12Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test13")]
//    [Route("{version:int}/{language:length(2)}/test13")]
//    public class Test13Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test14")]
//    [Route("{version:int}/{language:length(2)}/test14")]
//    public class Test14Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test15")]
//    [Route("{version:int}/{language:length(2)}/test15")]
//    public class Test15Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test16")]
//    [Route("{version:int}/{language:length(2)}/test16")]
//    public class Test16Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test17")]
//    [Route("{version:int}/{language:length(2)}/test17")]
//    public class Test17Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test18")]
//    [Route("{version:int}/{language:length(2)}/test18")]
//    public class Test18Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test19")]
//    [Route("{version:int}/{language:length(2)}/test19")]
//    public class Test19Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test20")]
//    [Route("{version:int}/{language:length(2)}/test20")]
//    public class Test20Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test21")]
//    [Route("{version:int}/{language:length(2)}/test21")]
//    public class Test21Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test22")]
//    [Route("{version:int}/{language:length(2)}/test22")]
//    public class Test22Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test23")]
//    [Route("{version:int}/{language:length(2)}/test23")]
//    public class Test23Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test24")]
//    [Route("{version:int}/{language:length(2)}/test24")]
//    public class Test24Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test25")]
//    [Route("{version:int}/{language:length(2)}/test25")]
//    public class Test25Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test26")]
//    [Route("{version:int}/{language:length(2)}/test26")]
//    public class Test26Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test27")]
//    [Route("{version:int}/{language:length(2)}/test27")]
//    public class Test27Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test28")]
//    [Route("{version:int}/{language:length(2)}/test28")]
//    public class Test28Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test29")]
//    [Route("{version:int}/{language:length(2)}/test29")]
//    public class Test29Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test30")]
//    [Route("{version:int}/{language:length(2)}/test30")]
//    public class Test30Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test31")]
//    [Route("{version:int}/{language:length(2)}/test31")]
//    public class Test31Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test32")]
//    [Route("{version:int}/{language:length(2)}/test32")]
//    public class Test32Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test33")]
//    [Route("{version:int}/{language:length(2)}/test33")]
//    public class Test33Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test34")]
//    [Route("{version:int}/{language:length(2)}/test34")]
//    public class Test34Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test35")]
//    [Route("{version:int}/{language:length(2)}/test35")]
//    public class Test35Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test36")]
//    [Route("{version:int}/{language:length(2)}/test36")]
//    public class Test36Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test37")]
//    [Route("{version:int}/{language:length(2)}/test37")]
//    public class Test37Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test38")]
//    [Route("{version:int}/{language:length(2)}/test38")]
//    public class Test38Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test39")]
//    [Route("{version:int}/{language:length(2)}/test39")]
//    public class Test39Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test40")]
//    [Route("{version:int}/{language:length(2)}/test40")]
//    public class Test40Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test41")]
//    [Route("{version:int}/{language:length(2)}/test41")]
//    public class Test41Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test42")]
//    [Route("{version:int}/{language:length(2)}/test42")]
//    public class Test42Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test43")]
//    [Route("{version:int}/{language:length(2)}/test43")]
//    public class Test43Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test44")]
//    [Route("{version:int}/{language:length(2)}/test44")]
//    public class Test44Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test45")]
//    [Route("{version:int}/{language:length(2)}/test45")]
//    public class Test45Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test46")]
//    [Route("{version:int}/{language:length(2)}/test46")]
//    public class Test46Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test47")]
//    [Route("{version:int}/{language:length(2)}/test47")]
//    public class Test47Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test48")]
//    [Route("{version:int}/{language:length(2)}/test48")]
//    public class Test48Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test49")]
//    [Route("{version:int}/{language:length(2)}/test49")]
//    public class Test49Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test50")]
//    [Route("{version:int}/{language:length(2)}/test50")]
//    public class Test50Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test51")]
//    [Route("{version:int}/{language:length(2)}/test51")]
//    public class Test51Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test52")]
//    [Route("{version:int}/{language:length(2)}/test52")]
//    public class Test52Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test53")]
//    [Route("{version:int}/{language:length(2)}/test53")]
//    public class Test53Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test54")]
//    [Route("{version:int}/{language:length(2)}/test54")]
//    public class Test54Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test55")]
//    [Route("{version:int}/{language:length(2)}/test55")]
//    public class Test55Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test56")]
//    [Route("{version:int}/{language:length(2)}/test56")]
//    public class Test56Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test57")]
//    [Route("{version:int}/{language:length(2)}/test57")]
//    public class Test57Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test58")]
//    [Route("{version:int}/{language:length(2)}/test58")]
//    public class Test58Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test59")]
//    [Route("{version:int}/{language:length(2)}/test59")]
//    public class Test59Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test60")]
//    [Route("{version:int}/{language:length(2)}/test60")]
//    public class Test60Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test61")]
//    [Route("{version:int}/{language:length(2)}/test61")]
//    public class Test61Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test62")]
//    [Route("{version:int}/{language:length(2)}/test62")]
//    public class Test62Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }

//    [Route("{language:length(2)}/test63")]
//    [Route("{version:int}/{language:length(2)}/test63")]
//    public class Test63Controller : ControllerBase
//    {
//        [Route("method-1"), HttpGet]
//        public IActionResult Get()
//        {
//            return Ok();
//        }

//        [Route("method-2"), HttpPost]
//        public IActionResult Post()
//        {
//            return Ok();
//        }

//        [Route("method-3"), HttpPost]
//        public IActionResult Post3()
//        {
//            return Ok();
//        }
//    }


//}