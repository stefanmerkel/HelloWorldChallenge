module Challenge where

  main = do
    let msg = "Hello world!"
    c1 msg
    c2 msg
    return ()

  c1 msg = putStrLn msg

  c2 msg = let msges = msg : msges
            in mapM (c1) $ take 2 msges

