// <auto-generated />
namespace PingYourPackage.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class addedIsLockedForUser : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201207222117026_addedIsLockedForUser"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAO1d3W7cuBW+L9B3GOiqLbAzTroFdoPxLrJ2vA0ax4bHCdCrgJY4YyISpZU4rv1svegj9RWWkkYSRfJQlDT6mbQ3QUYkDw/P+fh3yI/+77//s/75OfAXTzhOSEjPnVfLM2eBqRt6hO7OnT3bfveD8/NPf/zD+p0XPC8+F/n+mubjJWly7jwyFr1ZrRL3EQcoWQbEjcMk3LKlGwYr5IWr12dnP65evVphLsLhshaL9d2eMhLg7Af/eRFSF0dsj/zr0MN+cvjOUzaZ1MVHFOAkQi4+d265Zv8M9/Etcr+iHV5ehgEidPmOC2QEJ87irU8QV2uD/a2ziL5/8ynBGxaHdLeJECPIv3+JME/fIj/Bh0a8ib63bcfZ67QdK0RpyLi4kHayg1O2kLcxU/0lVStrJ29i3rT0i5iRZ/0Hfql94J9u4zDCMXu5w9tDcZ7JWazqBVdyybKcWCit8dz5dU88Z/Fx7/vowcelpVbG8um/hQBubu4kZ3FFnrH3AdMdeyylXKPn4svfOIY+UcLBxsuweI9bV3oRY8Swd0OLmi/5z3sSWEj6iJ7ILnOgJPNg/NuYuCma7rCf5UoeSZSDainm+CL6anEVh8Fd6EtSxDxf7lG8w4zrGzZk3HCMuy303nAFA0yZXuciFdJXl67oqs2k03O9qjBtg/Ss9ScDdaH1fUV9Rj7xUi+0B7BO0j3x/d6SBuxUOeqO3aUKBDZ2qQLPnaBagP/UYLrB1MPxkYTdYReTp6OJ69SFmkCWN9gEszzHF2HEVFAmZ4HGbSVf22FbMqxJ7SKPUXE1E6S6JmdH5cFu3WnWkbuzcWpqOztu+KINmNZrWUqj6NSt5wCnSSnbMSbKA7ZnOwR1XJ306JfA4A/23z7WLzvpbO0/h0X5Zh/TUertB7auoykAOMO422u5kQ0iJwO4QuvjDxzHHbKhOQYY2Tt58FPy/5HCXOnfUfKIvVuUJP8KY69l9fy/vUcq5LPxa32f"
                       + "fAjdr7hs7y8hhyCiY+7TJEkfUMI+RV6ztLy9tl037QDvadrB9ANxlf4l6ytCt5WSlCWWnN5rbVUJO5numqrcV0ba4OON07kH+3lZHpUhFNjqlLlUp1MpsoRnpZScpmBPydALfCcFu3Fmic4DSiu3ymAD/W7j1rdJErok00cT2axtf+ttfUe9hW14Kze7HC7j1t77jEQ+cbli585fFHta1FFiXKkj37LXq3jlyPi8oZfYxwwv3rosOyC6QImLPNW33H5e/QuHNI75Yosg/4J7k8WIUKbin1CXRMi3bIhU3rYHpQqWVckplzhKN5WUWTrMRgc5DqaqU9Yq2bHJbOuVgEkrqCq77wYUwVtxBURFSG5AGDWrp8F4tWNo6kN9UAoZakSQQsZogVEhjjwlSjXb9gYgmPbwClKrOOyYWDUFbcdGK2yuEfEKG6QFYmuHFZNgVhv/hrBgDoZ3gUGD7FOb9E2NGAObJgedzGQPhMyagAPFz1RY5gHLDtiETlWakT8faOrbMCY49Y6y0aAWu50Em3KoAEIMGDeooCLEdFpAEQw71QXPD3+A4mMAD3CGTdVlFGsStCnRAggVcOiggoUOaQOtGeEAVTf4dwIcZJMxEAcZwKbuMug5AuTyUBEvw3gJHB80KC6qpt/xszrzpmU2mKlrhsRZVMEn3XpNGda0ooqLjZCsQ1CpQZhwaKoIqqZpO43ynaVBpSJ8YCeuWPYbBFa7PMtmprPqPtGaTVr3NAhMYauTkk8rFoXL0KZWRNHnGwRBIrSFBXTrwVS/3SNkb7rcJ3fBFsHQskUKrpWO3SL8qUo9dDx5eK7bxN5e6g0X0FzmcFyrgJzarLLLNVsLjKMJUoX2HMtSuusZoK2agkItw0KqvYQxpdlihmjOQDbT37NTzdUcj7CPSNg0xT4GMVzPg+6IwNYxbY3bbI41FqrmEQtDARvigTCknNOqBjLuz6x2aILutcnMYA1oTyaJOoYJ1PND1QbmXYPdvkFQ"
                       + "vbn94HLfzpYGMxSHmeUKtUxbr3Le1eHDegUQtNbXKIoI3QmErcOXxSZna118t2lPkApyGSu3Zl15PV3WxMKYjxdSKq+aa3pF4oRdIoYeUHrQfOEFSjbL9XhRm2ZZrvquWFYVhdL/Hwqa2WtLw8BcGfeKtzft9lnTsX7oVEsvUjYd8lGsuxRwEfr7gBr2Z3D5/FKAKCD/Yi9BuMkkihE+q7LWK8kYyn5OcYOyxa67to3jD4vNATyvoUK1cT1QfCjfyyFtUVRTuBuWKrCiRIHC55aycl6UIiv//E3i1LQQ7o5RaE1kgU+46MDYFM6tNeg0nGo3Sq6dL2pkG88fG6V37FPTjovFvnKAgVFHfbFCXkP5vvCb1uDVxnQAk+v5Lm2MDkuY72qk5K+IQsqPswGAsqUcYqDXsE+s3N9Qfijn144wa+4znW1O5sJ833pMv+m25Rbu0hebbxeViSOiLDmtBXoyOkgNNtkXewkVtUOUUn0ddqkJyZLoHaI8KWlWPQMOsPTrHzqqRybYppdAhYfqK+URuSgDPDeH5ZTnnqIc8DB0Mr8f3+MdfT2ul+1HxEH9ogQE5Sxl7WVgUAoArg/BuOZnnJToXJ7FWXDTPBEvjcxtXhKGg2WaYbn5zb/wSRa4LzJcI0q2OGH34VdMz53XZ2c/SI8/dXiYaZUknj/r15n2lPy2xyS9qEC2JA3U9yDx0CcUu48oVig7fbmI6ZTCmrmIJ/NQUG+r61886S1WeUDIy24h9H08qJOUwUEw5RM8xwKA8hzPsQRrnuaZB2hP542TgRs25fMhs5w1pJdCuok9nRc1evtA87rGUJCd6vGKWeJU/05FIf1PAXr+c6+3J/pJkt+TeCBstKlblaR9S0InTX1L4kQebOgNUenxht7ypIcchhoSTtbe/YeE4Wn/+Y29CZh4+tuxPV4b6MM9Ba69DMvdPx3uXi+i/uS8/OrqZScya38G/qg8vP8pav0MmPQTostwTD4PfJ0YEX4+"
                       + "U+KEoBptKuwCqGmnwY4U9vGp5MCV/j60+V7s9PGJ6N8g8XxcNriOBzEu0xe4UjIkkfxbI49PxRSfCjLWPhwZMtOTv1VOiuw7kP7dxP7Oz8/PHe8h5N7OQxlGKh1Q12GbD1V2SDbUpifigtRqI4FcVw1MegNaVOxyoSYV6YY2AXzZJgq6DQPdUCvIOjXy1HXOk9JNZi3+QoIFFx3ksevk60l6OrHF2KQVXiRCVUA0OLkioApYuF7shOR4cVBQ2F+2NHiQSX9SnHeY4m5FtNVyak+Qym5irk9qiIH46X07wljNHpB6bqW6aSuqKa5/yWQGjHKF82xJHAe40vNkjCv08NEa2YIPrl7z5Etl4W968pV6QnaViPQvfFLs1hbJZZ73dBsWi3VJoyKLdKJ3jRny+Ar6bczIFrmMJ/MlZ5K9R/4Z+Xue5V3wgL339GbPoj3jTcbBg19b+adrflP9Gem9rvP6JspeHD9GE7Ird7yf3dBf9sT3Sr2vNKePgIh0M/Er5t9zX/K9CcO7l1LSx5BaCjqYr9wD3eMg8tNV4A3doCcM69Zsw7rF1pcE7WIUJAcZVXn+k8PPC55/+h2BOkc9lXYAAA=="; }
        }
    }
}
