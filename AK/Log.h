/**
 * @file Log.h
 * @author dynutOS team
 * @brief custom logging functionalities
 * @version 0.1
 * @date 2022-04-17
 * 
 * @copyright Copyright (c) 2022 dynutOS. All rights reserved.
 * @license MIT-License
 * 
 */

#pragma once

namespace Log {
    /**
     * @brief dbg
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void dbg(const char* component, const char* fmt, ...);

    /**
     * @brief info
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void info(const char* component, const char* fmt, ...);

    /**
     * @brief success
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void success(const char* component, const char* fmt, ...);

    /**
     * @brief warn
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void warn(const char* component, const char* fmt, ...);
    
    /**
     * @brief error
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void err(const char* component, const char* fmt, ...);

    /**
     * @brief critical
     * 
     * @param component 
     * @param fmt 
     * @param ... 
     */
	void crit(const char* component, const char* fmt, ...);
}