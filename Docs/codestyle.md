# Coding Style:

## Headers:
- wrong headers
```cpp
#ifndef YOUR_HEADER_NAME
#define YOUR_HEADER_NAME

// your code 

#endif
```

- right headers
```cpp
#pragma once

// your code goes here
```

## Namespace:
- always use namespace to store functions in it
- name of the namespace should be name of the file
```cpp
// String.h
namespace String {
    // your code goes here
}
```