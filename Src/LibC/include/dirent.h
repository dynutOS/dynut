#ifndef _DIRENT_H_
#define _DIRENT_H_

#include <stdint.h>

struct dirent {
    uint32_t d_ino;
    char d_name[256];
};

typedef struct {
    uint32_t fd;
    uint32_t current_entry;
} DIR;

DIR* opendir(char *path);
int32_t closedir(DIR *d);
struct dirent *readdir(DIR *d);

#endif 